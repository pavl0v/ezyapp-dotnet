create table "hotels_raw" (
  "id" uuid not null,
  "raw" jsonb not null,
  "created_at" timestamp without time zone default (now() at time zone 'utc'),
  "updated_at" timestamp without time zone default (now() at time zone 'utc'),
  constraint "hotels_raw_pk" primary key ("id")
);
